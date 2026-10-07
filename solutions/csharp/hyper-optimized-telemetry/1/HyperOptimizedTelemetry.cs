using System;
public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        
        if(reading >= 0 && reading <= (long)ushort.MaxValue)
        {
            //ushort    
            ushort value = (ushort)reading;
            byte[] payload = BitConverter.GetBytes(value);
            buffer[0] = 2;
            buffer[1] = payload[0];
            buffer[2] = payload[1];
        }
        else if(reading >= (long)short.MinValue && reading <= (long)short.MaxValue)
        {
            //short    
            short value = (short)reading;
            byte[] payload = BitConverter.GetBytes(value);
            buffer[0] = 256-2;
            buffer[1] = payload[0];
            buffer[2] = payload[1];

        }
        else if(reading >= 2147483648 && reading <= (long)uint.MaxValue)
        {
            //uint    
            uint value = (uint)reading;
            byte[] payload = BitConverter.GetBytes(value);
            buffer[0] = 4;
            buffer[1] = payload[0];
            buffer[2] = payload[1];
            buffer[3] = payload[2];
            buffer[4] = payload[3];
        }
        else if(reading >= 65536 && reading <= int.MaxValue || reading >= int.MinValue && reading <= -32769)
        {
            //int    
            int value = (int)reading;
            byte[] payload = BitConverter.GetBytes(value);
            buffer[0] = 256-4;
            buffer[1] = payload[0];
            buffer[2] = payload[1];
            buffer[3] = payload[2];
            buffer[4] = payload[3];
        }
        else if(reading >= 4294967296 && reading <= long.MaxValue || reading >= long.MinValue && reading <= -2147483649)
        {
            //long    
            long value = (long)reading;
            byte[] payload = BitConverter.GetBytes(value);
            buffer[0] = 256-8;
            buffer[1] = payload[0];
            buffer[2] = payload[1];
            buffer[3] = payload[2];
            buffer[4] = payload[3];
            buffer[5] = payload[4];
            buffer[6] = payload[5];
            buffer[7] = payload[6];
            buffer[8] = payload[7];

        }
        
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        if(buffer[0] == 2)
        {
            //ushort    
            ushort value = BitConverter.ToUInt16(buffer, 1);
            return value;
        }
        else if(buffer[0] == 254)
        {
            //short    
            short value = BitConverter.ToInt16(buffer, 1);
            return value;
        }
        else if(buffer[0] == 4)
        {
            //uint    
            uint value = BitConverter.ToUInt32(buffer, 1);
            return value;
        }
        else if(buffer[0] == 252)
        {
            //int    
            int value = BitConverter.ToInt32(buffer, 1);
            return value;
        }
        else if(buffer[0] == 248)
        {
            //long    
            long value = BitConverter.ToInt64(buffer, 1);
            return value;
        }
        return 0;
    }
}
