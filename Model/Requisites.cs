using System;
using Utils;

namespace hotel
{
    public class Requisites:
        Entity
    {
        public String OrganizationName
        {
            get
            {
                return _organizationName.Value;
            }
            private set { _organizationName.Value = value; }
        }

        public String BeneficiaryBank
        {
            get
            {
                return _beneficiaryBank.Value;
            }
            private set { _beneficiaryBank.Value = value; }
        }

        public String AccountNumber
        {
            get
            {
                return _accountNumber.Value;
            }
            private set { _accountNumber.Value = value; }
        }

        public String Iin
        {
            get
            {
                return _iin.Value;
            }
            private set { _iin.Value = value; }
        }

        public String BankIdentifierCode
        {
            get
            {
                return _bankIdentifierCode.Value;
            }
            private set { _bankIdentifierCode.Value = value; }
        }

        public Requisites()
        {
            
        }
        public Requisites ( Guid id, string name, string bank, string accountNumber, string iin, string bic )
            :base(id)
        {
            OrganizationName =  name;
            BeneficiaryBank =  bank;
            AccountNumber =  accountNumber;
            Iin =  iin;
            BankIdentifierCode = bic;
        }

        public override string ToString ()
        {
            return string.Format(
                       "Requisites:: id:{0} ",
                       id
                   );
        }

        private NonEmptyString _organizationName = new NonEmptyString("OrganizationName");

        private NonEmptyString _beneficiaryBank = new NonEmptyString("BeneficiaryBank");

        private NonEmptyString _accountNumber = new NonEmptyString("AccountNumber");

        private NonEmptyString _iin = new NonEmptyString("IIN");

        private NonEmptyString _bankIdentifierCode = new NonEmptyString("BankIdentifierCode");
    }
}
