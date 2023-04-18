namespace Retalix.Contracts.Generated.BusinessRoles
{
    using Retalix.Contracts.Generated.Common;
    using Retalix.Contracts.Generated.Arts.PosLogV6.Source;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BatchContractGenerator.Console", "30.100.999")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://retalix.com/R10/services")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://retalix.com/R10/services", IsNullable=true)]
    [Retalix.Commons.Contracts.ContractDocumentationAttributes.ContractSourceAttribute("Schemas\\BusinessRoles\\BusinessRoles.xsd")]
    public partial class BusinessRolesType
    {
        
        private int roleidField;
        
        private string businessUnitidField;
        
        private string rolecodeField;
        
        private string rolenameField;
        
        private ActionTypeCodes actionField;
        
        private bool actionFieldSpecified;
        
        private bool RoleidFieldSpecified;
        
        [Retalix.Commons.Contracts.ContractValidationAttributes.ContractRequiredAttribute()]
        public int Roleid
        {
            get
            {
                return this.roleidField;
            }
            set
            {
                this.roleidField = value;
                this.RoleidSpecified = true;
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        public string BusinessUnitid
        {
            get
            {
                return this.businessUnitidField;
            }
            set
            {
                this.businessUnitidField = value;
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        public string Rolecode
        {
            get
            {
                return this.rolecodeField;
            }
            set
            {
                this.rolecodeField = value;
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        public string Rolename
        {
            get
            {
                return this.rolenameField;
            }
            set
            {
                this.rolenameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActionTypeCodes Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.ActionSpecified = true;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RoleidSpecified
        {
            get
            {
                return this.RoleidFieldSpecified;
            }
            set
            {
                this.RoleidFieldSpecified = value;
            }
        }
    }
}
