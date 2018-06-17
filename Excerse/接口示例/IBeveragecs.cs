using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口示例
{
    public interface IBeveragecs
    {
        //方法、属性、事件、索引器
    }

    public interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }

        int AddPoints(decimal transValue);

        void ResetPoints();

    }
}
