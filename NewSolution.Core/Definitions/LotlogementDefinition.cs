
using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using XrmFramework;

namespace NewSolution.Core
{
    [GeneratedCode("XrmFramework", "2.0")]
    [EntityDefinition]
    [ExcludeFromCodeCoverage]
    public static class LotlogementDefinition
    {
        public const string EntityName = "cr5d4_lotlogement";
        public const string EntityCollectionName = "cr5d4_lotlogements";

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class Columns
        {
            /// <summary>
            /// 
            /// Type : Uniqueidentifier
            /// Validity :  Read | Create | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.Uniqueidentifier)]
            [PrimaryAttribute(PrimaryAttributeType.Id)]
            public const string Id = "cr5d4_lotlogementid";

            /// <summary>
            /// 
            /// Type : Integer
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.Integer)]
            [Range(-2147483648, 2147483647)]
            public const string NbProspect = "cr5d4_nbprospect";

            /// <summary>
            /// 
            /// Type : Integer
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.Integer)]
            [Range(-2147483648, 2147483647)]
            public const string Numero = "cr5d4_numero";

            /// <summary>
            /// 
            /// Type : Lookup
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.Lookup)]
            [CrmLookup("cr5d4_programmelogement", "cr5d4_programmelogementid", RelationshipName = "cr5d4_lotlogement_Programme_cr5d4_programmeloge")]
            public const string Programme = "cr5d4_programme";

            /// <summary>
            /// 
            /// Type : Money
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.Money)]
            [Range(-922337203685477, 922337203685477)]
            public const string PrixEuros = "dimsif_prixeuros";

        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class ManyToManyRelationships
        {
            [Relationship(AccountDefinition.EntityName, EntityRole.Referencing, "cr5d4_dimsif_account_cr5d4_lotlogement", "dimsif_accountid")]
            public const string cr5d4_dimsif_Account_cr5d4_LotLogement_cr5d4_Lo = "cr5d4_dimsif_Account_cr5d4_LotLogement_cr5d4_Lo";
        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class ManyToOneRelationships
        {
            [Relationship("businessunit", EntityRole.Referencing, "owningbusinessunit", "owningbusinessunit")]
            public const string business_unit_cr5d4_lotlogement = "business_unit_cr5d4_lotlogement";
            [Relationship("cr5d4_programmelogement", EntityRole.Referencing, "cr5d4_Programme", LotlogementDefinition.Columns.Programme)]
            public const string cr5d4_lotlogement_Programme_cr5d4_programmeloge = "cr5d4_lotlogement_Programme_cr5d4_programmeloge";
            [Relationship("systemuser", EntityRole.Referencing, "createdby", "createdby")]
            public const string lk_cr5d4_lotlogement_createdby = "lk_cr5d4_lotlogement_createdby";
            [Relationship("systemuser", EntityRole.Referencing, "createdonbehalfby", "createdonbehalfby")]
            public const string lk_cr5d4_lotlogement_createdonbehalfby = "lk_cr5d4_lotlogement_createdonbehalfby";
            [Relationship("systemuser", EntityRole.Referencing, "modifiedby", "modifiedby")]
            public const string lk_cr5d4_lotlogement_modifiedby = "lk_cr5d4_lotlogement_modifiedby";
            [Relationship("systemuser", EntityRole.Referencing, "modifiedonbehalfby", "modifiedonbehalfby")]
            public const string lk_cr5d4_lotlogement_modifiedonbehalfby = "lk_cr5d4_lotlogement_modifiedonbehalfby";
            [Relationship("owner", EntityRole.Referencing, "ownerid", "ownerid")]
            public const string owner_cr5d4_lotlogement = "owner_cr5d4_lotlogement";
            [Relationship("team", EntityRole.Referencing, "owningteam", "owningteam")]
            public const string team_cr5d4_lotlogement = "team_cr5d4_lotlogement";
            [Relationship("transactioncurrency", EntityRole.Referencing, "transactioncurrencyid", "transactioncurrencyid")]
            public const string TransactionCurrency_cr5d4_LotLogement = "TransactionCurrency_cr5d4_LotLogement";
            [Relationship("systemuser", EntityRole.Referencing, "owninguser", "owninguser")]
            public const string user_cr5d4_lotlogement = "user_cr5d4_lotlogement";
        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class OneToManyRelationships
        {
            [Relationship("asyncoperation", EntityRole.Referenced, "cr5d4_lotlogement_AsyncOperations", "regardingobjectid")]
            public const string cr5d4_lotlogement_AsyncOperations = "cr5d4_lotlogement_AsyncOperations";
            [Relationship("bulkdeletefailure", EntityRole.Referenced, "cr5d4_lotlogement_BulkDeleteFailures", "regardingobjectid")]
            public const string cr5d4_lotlogement_BulkDeleteFailures = "cr5d4_lotlogement_BulkDeleteFailures";
            [Relationship("duplicaterecord", EntityRole.Referenced, "cr5d4_lotlogement_DuplicateBaseRecord", "baserecordid")]
            public const string cr5d4_lotlogement_DuplicateBaseRecord = "cr5d4_lotlogement_DuplicateBaseRecord";
            [Relationship("duplicaterecord", EntityRole.Referenced, "cr5d4_lotlogement_DuplicateMatchingRecord", "duplicaterecordid")]
            public const string cr5d4_lotlogement_DuplicateMatchingRecord = "cr5d4_lotlogement_DuplicateMatchingRecord";
            [Relationship("mailboxtrackingfolder", EntityRole.Referenced, "cr5d4_lotlogement_MailboxTrackingFolders", "regardingobjectid")]
            public const string cr5d4_lotlogement_MailboxTrackingFolders = "cr5d4_lotlogement_MailboxTrackingFolders";
            [Relationship("principalobjectattributeaccess", EntityRole.Referenced, "cr5d4_lotlogement_PrincipalObjectAttributeAccesses", "objectid")]
            public const string cr5d4_lotlogement_PrincipalObjectAttributeAccesses = "cr5d4_lotlogement_PrincipalObjectAttributeAccesses";
            [Relationship("processsession", EntityRole.Referenced, "cr5d4_lotlogement_ProcessSession", "regardingobjectid")]
            public const string cr5d4_lotlogement_ProcessSession = "cr5d4_lotlogement_ProcessSession";
            [Relationship("syncerror", EntityRole.Referenced, "cr5d4_lotlogement_SyncErrors", "regardingobjectid")]
            public const string cr5d4_lotlogement_SyncErrors = "cr5d4_lotlogement_SyncErrors";
            [Relationship("userentityinstancedata", EntityRole.Referenced, "cr5d4_lotlogement_UserEntityInstanceDatas", "objectid")]
            public const string cr5d4_lotlogement_UserEntityInstanceDatas = "cr5d4_lotlogement_UserEntityInstanceDatas";
        }
    }
}
