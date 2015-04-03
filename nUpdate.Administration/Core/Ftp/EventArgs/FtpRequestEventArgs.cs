/*
 *  Authors:  Benton Stark
 * 
 *  Copyright (c) 2007-2009 Starksoft, LLC (http://www.starksoft.com) 
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 */

namespace nUpdate.Administration.Core.Ftp.EventArgs
{
    /// <summary>
    /// Event arguments to facilitate the FtpClient request event.
    /// </summary>
	public class FtpRequestEventArgs : System.EventArgs
	{
		private nUpdate.Administration.Core.Ftp.FtpRequest _request;

        /// <summary>
        /// Constructor for FtpRequestEventArgs.
        /// </summary>
        /// <param name="request">An FtpRequest object.</param>
 		public FtpRequestEventArgs(nUpdate.Administration.Core.Ftp.FtpRequest request)
		{
            _request = request;
		}

        /// <summary>
        /// Client request command text sent from the client to the server.
        /// </summary>
		public nUpdate.Administration.Core.Ftp.FtpRequest Request
		{
			get	{ return _request;	}
		}
	}

} 