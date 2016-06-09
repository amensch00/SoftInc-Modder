using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareInc_mod_exe.classes
{
    public class class_Feature
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

        #region Get/Set

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Devtime
        {
            get { return devtime; }
            set { devtime = value; }
        }


        public string Codeart
        {
            get { return codeart; }
            set { codeart = value; }
        }

        public string Innovation
        {
            get { return innovation; }
            set { innovation = value; }
        }

        public string Usability
        {
            get { return usability; }
            set { usability = value; }
        }

        public string Stability
        {
            get { return stability; }
            set { stability = value; }
        }

        public string Fromparent
        {
            get { return fromparent; }
            set { fromparent = value; }
        }

        public bool Forced
        {
            get { return forced; }
            set { forced = value; }
        }

        public List<string> Dependencies
        {
            get { return dependencies; }
            set { dependencies = value; }
        }

        #endregion
    }
}
