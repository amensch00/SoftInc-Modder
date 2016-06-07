using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareInc_mod_exe.classes
{
    class class_Feature
    {
        #region Properties

        private string
            name,
            description,
            devtime,
            codeart,
            innovation,
            usability,
            stability,
            fromparent;
            /*server*/
        private bool forced;
        private List<string> dependencies;

        #endregion

        #region Constructor
        public class_Feature(string nam, string desc, string dev, string art, string innov, string usa, string sta, string from, bool force, List<string> depend)
        {
            dependencies = new List<string>();

            name = nam;
            description = desc;
            devtime = dev;
            codeart = art;
            innovation = innov;
            usability = usa;
            stability = sta;
            fromparent = from;
            forced = force;
            dependencies = depend;
        }

        #endregion
    }
}
