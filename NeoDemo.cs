using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Neo.Lux.Core;
using Neo.Lux.Cryptography;
using Neo.Lux.Utils;

/* about wallet.db3 
 * password is test
 * address is AH78bx9sfVKR4cPaC527ktaDRjtwKNur8B
 * private key is a9e2b5436cab6ff74be2d5c91b8a67053494ab5b454ac2851f872fb0fd30ba5e
 */

public class NeoDemo : MonoBehaviour {

    private enum WalletState
    {
    Init,
    Sync,
    Update,
    Ready
    }

    private KeyPair keys;
    public Text addressLabel;
    public Text balanceLabel;
    public bool unlockedGas;
    public Button startBtn;
    private WalletState state = WalletState.Init;
    private decimal balance;
    private const string assetSymbol = "GAS";
    private NeoAPI api;

    void Start () {
    this.api = NeoRPC.ForTestNet();
    this.keys = new KeyPair("a9e2b5436cab6ff74be2d5c91b8a67053494ab5b454ac2851f872fb0fd30ba5e".HexToBytes());
    this.addressLabel.text = keys.address;
    this.balanceLabel.text = "Please wait, syncing balance...";       
    }


    IEnumerator SyncBalance()
    {
    yield return new WaitForSeconds(6);
    var balances = api.GetAssetBalancesOf(this.keys);
    this.balance = balances.ContainsKey(assetSymbol) ? balances[assetSymbol] : 0;
    this.state = WalletState.Update;
    }

    void Update () {

        if(balance == 4 || balance == 14 || balance == 24 || balance == 34 || balance == 44 || balance == 54)
        {
        unlockedGas = true;
        }

        switch (state)
        {
            case WalletState.Init:
                {
                state = WalletState.Sync;
                StartCoroutine(SyncBalance());
                break;
                }

            case WalletState.Update:
                {
                this.state = WalletState.Ready;
                this.balanceLabel.text = balance.ToString() + " "+ assetSymbol;
                this.startBtn.interactable = true;
                break;
                }
        }		
	}
}
