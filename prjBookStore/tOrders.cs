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
    
    public partial class tOrders
    {
        public int fOrderID { get; set; }
        public Nullable<int> fMemberID { get; set; }
        public string fOrderDate { get; set; }
        public Nullable<int> fEmployeeID { get; set; }
        public Nullable<int> fTransferID { get; set; }
        public string fOrderStatus { get; set; }
    
        public virtual tMember tMember { get; set; }
    }
}
