//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFArchive
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public int IdPerson { get; set; }
        public int NumberReception { get; set; }
        public System.DateTime DateReception { get; set; }
        public string Position { get; set; }
        public Nullable<int> NumberFired { get; set; }
        public Nullable<System.DateTime> DateFired { get; set; }
        public string СauseFired { get; set; }
        public string PersonalNumber { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
