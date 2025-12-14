using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace BlueDawn
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(
        "Mister Tricorder's Blue Dawn",
        "Calm, high-contrast blue theme with darker framing for better focus.",
        "2.0")]
    [Guid(PackageGuidString)]
    public sealed class BlueDawnPackage : AsyncPackage
    {
        public const string PackageGuidString = "7534e337-8818-4525-bb84-55d84187af2c";

        protected override async Task InitializeAsync(
            CancellationToken cancellationToken,
            IProgress<ServiceProgressData> progress)
        {
            await base.InitializeAsync(cancellationToken, progress);
        }
    }
}

