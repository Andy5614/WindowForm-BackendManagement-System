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
    
    public partial class tProducts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tProducts()
        {
            this.tCustomerWatchList = new HashSet<tCustomerWatchList>();
        }
    
        public int fProductId { get; set; }
        public string fProductBarcode { get; set; }
        public string fProductCategory { get; set; }
        public string fProductName { get; set; }
        public Nullable<decimal> fPrice { get; set; }
        public Nullable<decimal> fCost { get; set; }
        public Nullable<int> fQuantity { get; set; }
    
        public virtual tBook tBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCustomerWatchList> tCustomerWatchList { get; set; }
        public virtual tMerchandise tMerchandise { get; set; }
    }
}