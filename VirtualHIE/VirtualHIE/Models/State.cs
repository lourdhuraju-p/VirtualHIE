//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualHIE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class State
    {
        public State()
        {
            this.Hospitals = new HashSet<Hospital>();
        }
        [Display(Name = "State Name")]
        public int StateId { get; set; }
         [Display(Name = "State Name")]
        public string Name { get; set; }

        public virtual ICollection<Hospital> Hospitals { get; set; }
    }
}
