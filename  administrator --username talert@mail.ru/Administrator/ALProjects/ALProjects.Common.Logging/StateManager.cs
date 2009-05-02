using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALProjects.Core
{
    public class StateManager
    {
        #region singlation
        private static readonly StateManager _current;
        public StateManager Current
        {
            get { return _current; }
        }
        static StateManager()
        {

        }
        private StateManager()
        {

        }
        #endregion
    }
}
