using System.Runtime.Serialization;
using System;
namespace Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models {
    /// <summary>Describe whether all repositories have been selected or there&apos;s a selection involved</summary>
    public enum Installation_repository_selection {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "selected")]
        Selected,
    }
}
