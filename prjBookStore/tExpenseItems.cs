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
    
    public partial class tExpenseItems
    {
        public int fReportItemId { get; set; }
        public int fReportId { get; set; }
        public int fCategoryId { get; set; }
        public string fReportItemName { get; set; }
        public Nullable<int> fQty { get; set; }
        public Nullable<decimal> fAmount { get; set; }
        public string fAmountDescription { get; set; }
    
        public virtual tExpenseCategories tExpenseCategories { get; set; }
        public virtual tExpenseReports tExpenseReports { get; set; }
    }
}
