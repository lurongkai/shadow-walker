using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowWalker.Core
{
    public class WalkerMan
    {
        private WalkerMan() { }

        public static WalkerMan InitializeWith(ISynchronizeStrategy synchronizeStrategy)
        {
            throw new NotImplementedException();
        }

        public Task<TargetDescriptionBase> DoSynchronization() {
            throw new NotImplementedException();
        }
    }
}
