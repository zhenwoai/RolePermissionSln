//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace My.RolePermission.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SMUSERTB
    {
        public SMUSERTB()
        {
            this.SMLOG = new HashSet<SMLOG>();
            this.SMROLETB = new HashSet<SMROLETB>();
            this.SMROLETB1 = new HashSet<SMROLETB>();
            this.SMUSERTB1 = new HashSet<SMUSERTB>();
            this.SMUSERTB11 = new HashSet<SMUSERTB>();
            this.SMROLETB2 = new HashSet<SMROLETB>();
        }
    
        public int USER_ID { get; set; }
        public string U_ID { get; set; }
        public string U_PASSWORD { get; set; }
        public string GENDER { get; set; }
        public string USER_NAME { get; set; }
        public Nullable<System.DateTime> CREATION_TIME { get; set; }
        public Nullable<int> CREATION_USER { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
        public Nullable<int> UPDATE_USER { get; set; }
        public string STATUS { get; set; }
        public Nullable<int> COMPONENT_ID { get; set; }
        public Nullable<int> ISAUDIT { get; set; }
    
        public virtual ICollection<SMLOG> SMLOG { get; set; }
        public virtual ICollection<SMROLETB> SMROLETB { get; set; }
        public virtual ICollection<SMROLETB> SMROLETB1 { get; set; }
        public virtual ICollection<SMUSERTB> SMUSERTB1 { get; set; }
        public virtual SMUSERTB SMUSERTB2 { get; set; }
        public virtual ICollection<SMUSERTB> SMUSERTB11 { get; set; }
        public virtual SMUSERTB SMUSERTB3 { get; set; }
        public virtual ICollection<SMROLETB> SMROLETB2 { get; set; }
    }
}