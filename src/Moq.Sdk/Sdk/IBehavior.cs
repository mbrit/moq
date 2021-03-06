﻿#region BSD License
/*
Copyright (c) 2007. Clarius Consulting, Manas Technology Solutions, InSTEDD
http://moq.me
All rights reserved.

Redistribution and use in source and binary forms, 
with or without modification, are permitted provided 
that the following conditions are met:

    * Redistributions of source code must retain the 
    above copyright notice, this list of conditions and 
    the following disclaimer.

    * Redistributions in binary form must reproduce 
    the above copyright notice, this list of conditions 
    and the following disclaimer in the documentation 
    and/or other materials provided with the distribution.

    * Neither the name of Clarius Consulting, Manas Technology 
	Solutions or InSTEDD nor the names of its contributors 
	may be used to endorse or promote products derived from 
	this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
SUCH DAMAGE.

See also: http://www.opensource.org/licenses/bsd-license.php
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moq.Sdk
{
	/// <summary>
	/// Specifies a piece of behavior that affects 
	/// a mock invocation.
	/// </summary>
	public interface IBehavior
	{
		/// <summary>
		/// Determines whether this behavior is active for 
		/// the given invocation. 
		/// </summary>
		/// <remarks>
		/// This allows conditional behaviors, which 
		/// would enable some scenarios like ordering.
		/// </remarks>
		bool IsActiveFor(IInvocation invocation);

		/// <summary>
		/// Executes the behavior for the given invocation.
		/// </summary>
		/// <param name="invocation">The invocation that triggers the behavior.</param>
		/// <returns>A value indicating whether the behavior pipeline for this 
		/// particular phase of the invocation should continue or stop.</returns>
		BehaviorAction ExecuteFor(IInvocation invocation);
	}
}
