using System;

namespace MigraPlastifluor
{ 
    public class DbLogger
    {
        public static void Log(string reason, string message)
        {
            var context = new Context();
            var log = new LogData
            {
                Timestamp = DateTime.Now,
                Reason = reason,
                Message = message
            };

            context.LogData.Add(log);
            context.SaveChanges();
        }
    }
}