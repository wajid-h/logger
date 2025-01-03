
using System.Security.Cryptography.X509Certificates;

namespace Logger.Core {

	public class Log {
	
		public  static LogSettings?  Settings  {get ;  set ;}

		public  static void Error(string err){
			WriteLog(LoggingLevel.Error, err);
		} 
		public static void Warning(string warn){
			WriteLog(LoggingLevel.Warning, warn);
		}
		public static void Debug(string dbgMessage){
			WriteLog(LoggingLevel.Debug ,  dbgMessage) ; 
		}
		public static  void Info (string inf){
			WriteLog(LoggingLevel.Information , inf);
		}		
		public static void Fatal (string fatality){
			WriteLog(LoggingLevel.Fatal , fatality);
		}

		public static void Verbose(string verbose , bool  padstart = default , bool padend = default) {
			if(padstart) Console.Write("\n");
			WriteLog(LoggingLevel.Verbose , verbose);
			if(padend)Console.Write("\n"); 
		}

		private  static void WriteLog(LoggingLevel logLevel, string message){
		
			if(Settings ==  null) {
				Console.WriteLine("logger__internal_warn: logging settings have not been configured, using fallback settings.");
			
				Settings   =  new (
					LoggingLevel.Debug,
					null 
				); 
			}	
	
	
			if((int)logLevel < (int)Settings.Level)
			return; 

			DateTime timeStamp =  DateTime.Now;
			string typeSuffix =  logLevel.ToString();
			string  logMessageTimeStamp =  $"{timeStamp.Hour : 00}:{timeStamp.Minute:00}:{timeStamp.Second:00}";
			string logMessageEntry =  $"[{logMessageTimeStamp} - {typeSuffix}]:{message}" ;
			string logFileEntry = $"[{timeStamp} - {typeSuffix}] {message}";
			Console.WriteLine(logMessageEntry);
		}	
	}
				
}
