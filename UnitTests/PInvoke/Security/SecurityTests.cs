﻿using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Vanara.Extensions;
using Vanara.InteropServices;
using static Vanara.PInvoke.AdvApi32;

namespace Vanara.PInvoke.Tests
{
	[TestFixture()]
	public class SecurityTests
	{
		[Test]
		public void MSChapSrvChangePasswordTest()
		{
			Assert.That(MSChapSrvChangePassword(null, Environment.UserName, false, default, default, default, default), ResultIs.Successful);
			Assert.That(MSChapSrvChangePassword2(null, Environment.UserName, default, default, false, default, default), ResultIs.Successful);
		}
	}
}