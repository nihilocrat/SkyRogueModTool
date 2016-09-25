using UnityEngine;

namespace SkyRogueModTool
{
    public class CustomAeroTemplate : MonoBehaviour
    {
        [Tooltip(
            @"If this matches a built-in aero name, the Airfoil, Destroyable, etc stats will be changed to match that aero
            ex: 'Aeroplane_falke' will match the Falke"
        )]
        public string templateName = "";
    }
}
