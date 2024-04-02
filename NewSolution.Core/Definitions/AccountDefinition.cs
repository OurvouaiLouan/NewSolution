using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using XrmFramework;

namespace NewSolution.Core
{
    [GeneratedCode("XrmFramework", "2.0")]
    [EntityDefinition]
    [ExcludeFromCodeCoverage]
    public static class AccountDefinition
    {
        public const string EntityName = "dimsif_account";
        public const string EntityCollectionName = "dimsif_accounts";

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class Columns
        {
            /// <summary>
            /// 
            /// Type : String
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.String)]
            [StringLength(100)]
            public const string Adresseemail = "cr5d4_adresseemail";

            /// <summary>
            /// 
            /// Type : DateTime
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.DateTime)]
            [DateTimeBehavior(DateTimeBehavior.UserLocal)]
            public const string Datedenaissance = "cr5d4_datedenaissance";

            /// <summary>
            /// 
            /// Type : String
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.String)]
            [StringLength(100)]
            public const string Prenom = "cr5d4_prenom";

            /// <summary>
            /// 
            /// Type : String
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.String)]
            [StringLength(100)]
            public const string TelephoneFixe = "cr5d4_telephonefixe";

            /// <summary>
            /// 
            /// Type : String
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.String)]
            [StringLength(100)]
            public const string TelephonePortable = "cr5d4_telephoneportable";

            /// <summary>
            /// 
            /// Type : Uniqueidentifier
            /// Validity :  Read | Create | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.Uniqueidentifier)]
            [PrimaryAttribute(PrimaryAttributeType.Id)]
            public const string Id = "dimsif_accountid";

            /// <summary>
            /// 
            /// Type : String
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.String)]
            [PrimaryAttribute(PrimaryAttributeType.Name)]
            [StringLength(100)]
            public const string Name = "dimsif_name";

        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class ManyToManyRelationships
        {
            [Relationship(LotlogementDefinition.EntityName, EntityRole.Referencing, "cr5d4_dimsif_account_cr5d4_lotlogement", "cr5d4_lotlogementid")]
            public const string cr5d4_dimsif_Account_cr5d4_LotLogement_cr5d4_Lo = "cr5d4_dimsif_Account_cr5d4_LotLogement_cr5d4_Lo";
        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class ManyToOneRelationships
        {
            [Relationship("businessunit", EntityRole.Referencing, "owningbusinessunit", "owningbusinessunit")]
            public const string business_unit_dimsif_account = "business_unit_dimsif_account";
            [Relationship("systemuser", EntityRole.Referencing, "createdby", "createdby")]
            public const string lk_dimsif_account_createdby = "lk_dimsif_account_createdby";
            [Relationship("systemuser", EntityRole.Referencing, "createdonbehalfby", "createdonbehalfby")]
            public const string lk_dimsif_account_createdonbehalfby = "lk_dimsif_account_createdonbehalfby";
            [Relationship("systemuser", EntityRole.Referencing, "modifiedby", "modifiedby")]
            public const string lk_dimsif_account_modifiedby = "lk_dimsif_account_modifiedby";
            [Relationship("systemuser", EntityRole.Referencing, "modifiedonbehalfby", "modifiedonbehalfby")]
            public const string lk_dimsif_account_modifiedonbehalfby = "lk_dimsif_account_modifiedonbehalfby";
            [Relationship("owner", EntityRole.Referencing, "ownerid", "ownerid")]
            public const string owner_dimsif_account = "owner_dimsif_account";
            [Relationship("team", EntityRole.Referencing, "owningteam", "owningteam")]
            public const string team_dimsif_account = "team_dimsif_account";
            [Relationship("systemuser", EntityRole.Referencing, "owninguser", "owninguser")]
            public const string user_dimsif_account = "user_dimsif_account";
        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class OneToManyRelationships
        {
            [Relationship("asyncoperation", EntityRole.Referenced, "dimsif_account_AsyncOperations", "regardingobjectid")]
            public const string dimsif_account_AsyncOperations = "dimsif_account_AsyncOperations";
            [Relationship("bulkdeletefailure", EntityRole.Referenced, "dimsif_account_BulkDeleteFailures", "regardingobjectid")]
            public const string dimsif_account_BulkDeleteFailures = "dimsif_account_BulkDeleteFailures";
            [Relationship("duplicaterecord", EntityRole.Referenced, "dimsif_account_DuplicateBaseRecord", "baserecordid")]
            public const string dimsif_account_DuplicateBaseRecord = "dimsif_account_DuplicateBaseRecord";
            [Relationship("duplicaterecord", EntityRole.Referenced, "dimsif_account_DuplicateMatchingRecord", "duplicaterecordid")]
            public const string dimsif_account_DuplicateMatchingRecord = "dimsif_account_DuplicateMatchingRecord";
            [Relationship("mailboxtrackingfolder", EntityRole.Referenced, "dimsif_account_MailboxTrackingFolders", "regardingobjectid")]
            public const string dimsif_account_MailboxTrackingFolders = "dimsif_account_MailboxTrackingFolders";
            [Relationship("principalobjectattributeaccess", EntityRole.Referenced, "dimsif_account_PrincipalObjectAttributeAccesses", "objectid")]
            public const string dimsif_account_PrincipalObjectAttributeAccesses = "dimsif_account_PrincipalObjectAttributeAccesses";
            [Relationship("processsession", EntityRole.Referenced, "dimsif_account_ProcessSession", "regardingobjectid")]
            public const string dimsif_account_ProcessSession = "dimsif_account_ProcessSession";
            [Relationship("syncerror", EntityRole.Referenced, "dimsif_account_SyncErrors", "regardingobjectid")]
            public const string dimsif_account_SyncErrors = "dimsif_account_SyncErrors";
            [Relationship("userentityinstancedata", EntityRole.Referenced, "dimsif_account_UserEntityInstanceDatas", "objectid")]
            public const string dimsif_account_UserEntityInstanceDatas = "dimsif_account_UserEntityInstanceDatas";
        }
    }
}
