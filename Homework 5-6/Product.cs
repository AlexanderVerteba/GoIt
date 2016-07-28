using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Product
    {
        public String _sName { get;  private set; }
        public Decimal _dPrice { get; private set; }

        public Product(String _sNameArg, Decimal _dPriceArg)
        {
            _sName = _sNameArg;
            _dPrice = _dPriceArg;
        }
    }
}
