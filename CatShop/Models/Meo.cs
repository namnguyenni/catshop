//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meo
    {
        public Meo()
        {
            this.BestCats = new HashSet<BestCat>();
            this.LastNews = new HashSet<LastNew>();
            this.MaxMonneyCats = new HashSet<MaxMonneyCat>();
            this.SellerCats = new HashSet<SellerCat>();
        }
    
        public string Id { get; set; }
        public string MauSac { get; set; }
        public string DacDiemNoiBat { get; set; }
        public Nullable<double> CanNang { get; set; }
        public Nullable<int> Ngaytuoi { get; set; }
        public string GiaBan { get; set; }
        public string img { get; set; }
        public string Ma_Loai { get; set; }
        public string Ma_PerSon { get; set; }
    
        public virtual LoaiMeo LoaiMeo { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<BestCat> BestCats { get; set; }
        public virtual ICollection<LastNew> LastNews { get; set; }
        public virtual ICollection<MaxMonneyCat> MaxMonneyCats { get; set; }
        public virtual ICollection<SellerCat> SellerCats { get; set; }
    }
}
