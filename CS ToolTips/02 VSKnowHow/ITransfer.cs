using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VSKnowHow
{
    public interface ITransfer
    {
        void Transfer(string from, string to, decimal amount);
        int Timeout { get; set; }
    }

    public class AccountTransfer : ITransfer
    {
        int ITransfer.Timeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void ITransfer.Transfer(string from, string to, decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class Client
    {
        void Test()
        {
            var acct = (ITransfer)new AccountTransfer();    // as ITransfer;
            // ITransfer tx = acct as ITransfer
            acct.Transfer("A", "B", 1000);
        }
    }
}
