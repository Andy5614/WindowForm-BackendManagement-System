//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjBookStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class tCustomerService
    {
        public int tCustomerServiceID { get; set; }
        public string fDate { get; set; }
        public Nullable<int> fEmployeeID { get; set; }
        public Nullable<int> fProblemId { get; set; }
        public string fType { get; set; }
        public string fContent { get; set; }
        public Nullable<int> fParentId { get; set; }
        public Nullable<int> fMemberID { get; set; }
    
        public virtual tEmployee tEmployee { get; set; }
        public virtual tMember tMember { get; set; }
        public virtual tProblem tProblem { get; set; }
    }
}