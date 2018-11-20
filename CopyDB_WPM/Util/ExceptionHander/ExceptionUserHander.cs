using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDB_WPM.Util.ExceptionHander
{
    /*
        
        Try Catch 문에서 Exception 처리를 여기서 하시면됩니다.
        예를 들어 텍스트 파일에 Message를 추가한다던가
        데이터베이스에 오류를 기록한다던지를 해 주시면 되겠습니다.
     
        You can process an Exception here in the Try Catch statement.
        For example, adding messages to a text file.
        Just write down the error in the database.

     */

    static class ExceptionUserHander
    {
        public static void SqlExcetionUserHander(Exception e)
        {
            Debug.WriteLine(e.Message);
        }

        public static void NomalExcetionUserHander(Exception e)
        {
            Debug.WriteLine(e.Message);
        }

    }
}
