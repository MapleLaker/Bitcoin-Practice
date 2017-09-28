using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace ProgrammingBlockchain.Chapters
{
	class Chapter1
	{

		public void Lesson1()
		{
			/*
            Key key = new Key(); //generates a new private key.     
            PubKey pubKey = key.PubKey; //gets the matching public key.     
            Console.WriteLine("Public Key: {0}", pubKey);
            KeyId hash = pubKey.Hash; //gets a hash of the public key.     
            Console.WriteLine("Hashed public key: {0}", hash);
            BitcoinAddress address = pubKey.GetAddress(Network.Main); //retrieves the bitcoin address.     
            Console.WriteLine("Address: {0}", address);
            Script scriptPubKeyFromAddress = address.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from address: {0}", scriptPubKeyFromAddress);
            Script scriptPubKeyFromHash = hash.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from hash: {0}", scriptPubKeyFromHash);
            */

			Key privatekey = new Key();
			PubKey publicKey = privatekey.PubKey;
			Console.WriteLine(publicKey);

			KeyId hash = publicKey.Hash;
			Console.WriteLine(hash);

			BitcoinAddress mainaddress = publicKey.GetAddress(Network.Main);
			Console.WriteLine(mainaddress);

		}


	}
}


