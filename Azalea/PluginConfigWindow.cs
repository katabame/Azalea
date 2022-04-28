﻿using Dalamud.Divination.Common.Api.Ui.Window;
using ImGuiNET;

namespace Divination.Template
{
    public class PluginConfigWindow : ConfigWindow<PluginConfig>
    {
        public override void Draw()
        {
            if (ImGui.Begin("Azalea Config", ref IsOpen, ImGuiWindowFlags.NoResize | ImGuiWindowFlags.AlwaysAutoResize))
            {
                ImGui.Text("This is config window.");

                ImGui.Separator();

                if (ImGui.Button("Save & Close"))
                {
                    IsOpen = false;
                    Save();
                }

                ImGui.End();
            }
        }
    }
}
