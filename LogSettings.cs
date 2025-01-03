
using System.Net; 

namespace Logger.Core {

	public class LogSettings (LoggingLevel level_,  IPEndPoint?remoteServerEndpoint_ =  null){

		/// set some stuff up 
		// logging level [verbose, debug, warrning, error , or sum shi]
		
		public  LoggingLevel Level {get =>  level ;  }
		public  IPEndPoint? Endpoint {get =>  remoteServerEndpoint ; }	

		private  readonly LoggingLevel level  = level_;
		private readonly IPEndPoint? remoteServerEndpoint = remoteServerEndpoint_;
	
	}

	[Flags]
	public enum LoggingLevel {
		Debug = 1 ,
		Verbose  = 2,
		Information =  4,
		Warning = 8,
		Error =  16,
		Fatal = 32
	}
				
}

