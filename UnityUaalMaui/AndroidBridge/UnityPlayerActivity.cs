using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Unity3d.Player;

public partial class UnityPlayerActivity : global::Com.Unity3d.Player.IUnityPlayerSupport
{
    UnityPlayer? IUnityPlayerSupport.UnityPlayerConnection => this.UnityPlayerConnection;

}
