using System.ComponentModel;
using XrmFramework;

namespace NewSolution.Core
{


    [OptionSetDefinition("componentstate")]
    public enum EtatDuComposant
    {
        [Description("Publié")]
        Publie = 0,
        [Description("Non publié")]
        NonPublie = 1,
        [Description("Supprimé")]
        Supprime = 2,
        [Description("Non publié supprimé")]
        NonPublieSupprime = 3,
    }


    [OptionSetDefinition("synapselinkprofileentitytype")]
    public enum SynapseLinkProfileEntityType
    {
        [Description("Requested")]
        Requested = 0,
    }

    [OptionSetDefinition("synapselinkscheduletype")]
    public enum SynapseLinkScheduleType
    {
        [Description("Snapshot")]
        Snapshot = 0,
        [Description("IncrementalUpdate")]
        Incrementalupdate = 1,
    }

}
