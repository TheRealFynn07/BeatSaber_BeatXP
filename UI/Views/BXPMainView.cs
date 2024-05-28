﻿using BeatXP.UI.Flows;
using BeatSaberMarkupLanguage.ViewControllers;
using BeatSaberMarkupLanguage.Attributes;
using UnityEngine;
using Zenject;

namespace BeatXP.UI.Views
{
    [HotReload(RelativePathToLayout = @"../MainView.bsml")]
    [ViewDefinition("BeatXP.UI.MainView.bsml")]
    class BXPMainView : BSMLAutomaticViewController
    {
        [Inject] private readonly BXPMainFlow _bxpFlow;
        [Inject] private readonly BXPTrackFlow _bxpTrackFlow;

        [UIAction("OpenDiscordLink")]
        private void OpenDiscordLink() => Application.OpenURL("https://discord.gg/tbJTZjjf6d");

        [UIAction("OpenFynnLink")]
        private void OpenFynnLink() => Application.OpenURL("https://discord.com/users/445200938815455239");

        [UIAction("OpenRileyLink")]
        private void OpenRileyLink() => Application.OpenURL("https://discord.com/users/628480432467607552");

        [UIAction("OpenTrackView")]
        private void OpenTrackView() => _bxpFlow.PresentFlowCoordinator(_bxpTrackFlow);
    }
}
