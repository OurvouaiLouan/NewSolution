
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
    public static class MonstreDefinition
    {
        public const string EntityName = "dimsif_monstre";
        public const string EntityCollectionName = "dimsif_monstres";

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
            public const string Id = "dimsif_monstreid";

            /// <summary>
            /// 
            /// Type : String
            /// Validity :  Read | Create | Update | AdvancedFind 
            /// </summary>
            [AttributeMetadata(AttributeTypeCode.String)]
            [PrimaryAttribute(PrimaryAttributeType.Name)]
            [StringLength(100)]
            public const string Nom = "dimsif_nom";

        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class ManyToOneRelationships
        {
            [Relationship("businessunit", EntityRole.Referencing, "owningbusinessunit", "owningbusinessunit")]
            public const string business_unit_dimsif_monstre = "business_unit_dimsif_monstre";
            [Relationship("imagedescriptor", EntityRole.Referencing, "dimsif_imageid_imagedescriptor", "dimsif_imageid")]
            public const string ImageDescriptor_dimsif_monstre_dimsif_image = "ImageDescriptor_dimsif_monstre_dimsif_image";
            [Relationship("systemuser", EntityRole.Referencing, "createdby", "createdby")]
            public const string lk_dimsif_monstre_createdby = "lk_dimsif_monstre_createdby";
            [Relationship("systemuser", EntityRole.Referencing, "createdonbehalfby", "createdonbehalfby")]
            public const string lk_dimsif_monstre_createdonbehalfby = "lk_dimsif_monstre_createdonbehalfby";
            [Relationship("systemuser", EntityRole.Referencing, "modifiedby", "modifiedby")]
            public const string lk_dimsif_monstre_modifiedby = "lk_dimsif_monstre_modifiedby";
            [Relationship("systemuser", EntityRole.Referencing, "modifiedonbehalfby", "modifiedonbehalfby")]
            public const string lk_dimsif_monstre_modifiedonbehalfby = "lk_dimsif_monstre_modifiedonbehalfby";
            [Relationship("owner", EntityRole.Referencing, "ownerid", "ownerid")]
            public const string owner_dimsif_monstre = "owner_dimsif_monstre";
            [Relationship("team", EntityRole.Referencing, "owningteam", "owningteam")]
            public const string team_dimsif_monstre = "team_dimsif_monstre";
            [Relationship("systemuser", EntityRole.Referencing, "owninguser", "owninguser")]
            public const string user_dimsif_monstre = "user_dimsif_monstre";
        }

        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static class OneToManyRelationships
        {
            [Relationship("asyncoperation", EntityRole.Referenced, "dimsif_monstre_AsyncOperations", "regardingobjectid")]
            public const string dimsif_monstre_AsyncOperations = "dimsif_monstre_AsyncOperations";
            [Relationship("bulkdeletefailure", EntityRole.Referenced, "dimsif_monstre_BulkDeleteFailures", "regardingobjectid")]
            public const string dimsif_monstre_BulkDeleteFailures = "dimsif_monstre_BulkDeleteFailures";
            [Relationship("duplicaterecord", EntityRole.Referenced, "dimsif_monstre_DuplicateBaseRecord", "baserecordid")]
            public const string dimsif_monstre_DuplicateBaseRecord = "dimsif_monstre_DuplicateBaseRecord";
            [Relationship("duplicaterecord", EntityRole.Referenced, "dimsif_monstre_DuplicateMatchingRecord", "duplicaterecordid")]
            public const string dimsif_monstre_DuplicateMatchingRecord = "dimsif_monstre_DuplicateMatchingRecord";
            [Relationship("mailboxtrackingfolder", EntityRole.Referenced, "dimsif_monstre_MailboxTrackingFolders", "regardingobjectid")]
            public const string dimsif_monstre_MailboxTrackingFolders = "dimsif_monstre_MailboxTrackingFolders";
            [Relationship("principalobjectattributeaccess", EntityRole.Referenced, "dimsif_monstre_PrincipalObjectAttributeAccesses", "objectid")]
            public const string dimsif_monstre_PrincipalObjectAttributeAccesses = "dimsif_monstre_PrincipalObjectAttributeAccesses";
            [Relationship("processsession", EntityRole.Referenced, "dimsif_monstre_ProcessSession", "regardingobjectid")]
            public const string dimsif_monstre_ProcessSession = "dimsif_monstre_ProcessSession";
            [Relationship("syncerror", EntityRole.Referenced, "dimsif_monstre_SyncErrors", "regardingobjectid")]
            public const string dimsif_monstre_SyncErrors = "dimsif_monstre_SyncErrors";
            [Relationship("userentityinstancedata", EntityRole.Referenced, "dimsif_monstre_UserEntityInstanceDatas", "objectid")]
            public const string dimsif_monstre_UserEntityInstanceDatas = "dimsif_monstre_UserEntityInstanceDatas";
        }
    }
}
