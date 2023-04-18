namespace Retalix.Contracts.Generated.BusinessRoles
{
    using Retalix.Contracts.Generated.Common;
    using Retalix.Contracts.Generated.Arts.PosLogV6.Source;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("BatchContractGenerator.Console", "30.100.999")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://retalix.com/R10/services")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://retalix.com/R10/services", IsNullable=false)]
    [Retalix.Commons.Contracts.ContractDocumentationAttributes.ContractSourceAttribute("Schemas\\BusinessRoles\\BusinessRoles.xsd")]
    public partial class BusinessRolesLookupRequest : Retalix.Contracts.Interfaces.IHeaderRequest
    {
        
        private RetalixCommonHeaderType headerField;
        
        private int roleidField;
        
        private bool RoleidFieldSpecified;
        
        public RetalixCommonHeaderType Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
        
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
