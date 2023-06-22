using System.Runtime.Serialization;
using System;
namespace Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models {
    /// <summary>The level of permission to grant the access token to manage repository secrets.</summary>
    public enum AppPermissions_secrets {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write,
    }
}
