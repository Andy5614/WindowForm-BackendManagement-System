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
    
    public partial class tBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tBook()
        {
            this.tCatagory = new HashSet<tCatagory>();
        }
    
        public string fIsbn { get; set; }
        public string fTitle { get; set; }
        public string fLanguage { get; set; }
        public string fPublisher { get; set; }
        public Nullable<System.DateTime> fPublishDate { get; set; }
        public string fEdition { get; set; }
        public string fPublishRegion { get; set; }
        public string fCover { get; set; }
        public Nullable<int> fPage { get; set; }
        public string fBookImagePath { get; set; }
        public Nullable<int> fBookRating { get; set; }
        public string fLevel { get; set; }
        public string fType { get; set; }
        public Nullable<int> fBookCategoryId { get; set; }
    
        public virtual tCategory tCategory { get; set; }
        public virtual tProducts tProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCatagory> tCatagory { get; set; }
    }
}
