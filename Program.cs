using Logger.Core;



// log level is set to warnning and beyond, anything with less priority that of a
// warnning is expected to be ignored.

// priority table
// Debug    =   1   
// Verbose  =   2
// Info     =   4
// Warn     =   8 
// Error    =   16


Log.Debug("this is debug");
Log.Warning("This is a test warnning ");
Log.Info("this is some information ") ;
Log.Error("this is an error") ;