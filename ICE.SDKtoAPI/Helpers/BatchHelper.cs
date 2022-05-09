using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Helpers
{
    public static class BatchHelper
    {
        public static LoanBatchUpdateRequestContract BatchUpdate(List<string> guids)
        {
            return new LoanBatchUpdateRequestContract()
            {
                LoanGuids = guids,
                LoanFields = new List<LoanBatchUpdateRequestContractLoanFields>(),
                //                LoanData = new LoanContract()
                //                {
                //                    Property = new LoanContractProperty()
                //                }
            };
        }
        public static LoanBatchUpdateRequestContract BatchUpdate(string guid)
        {
            var guids = new List<string>();
            guids.Add(guid);
            return new LoanBatchUpdateRequestContract()
            {
                LoanGuids = guids,
                LoanFields = new List<LoanBatchUpdateRequestContractLoanFields>(),
                //                LoanData = new LoanContract()
                //                {
                //                    Property = new LoanContractProperty()
                //                }
            };
        }

        public static void FieldsAdd(this LoanBatchUpdateRequestContract obj, string id, object value)
        {
            obj.LoanFields.Add(new LoanBatchUpdateRequestContractLoanFields()
            {
                FieldId = id,
                Value = value
            });

        }
    }
}
