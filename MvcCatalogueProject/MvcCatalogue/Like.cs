//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace MvcCatalogue
{
    using System.ComponentModel.DataAnnotations;

    public partial class Like
    {
        [Key]
        public int Id { get; set; }

        public int ProductID { get; set; }

        public int Likes { get; set; }
    }
}
