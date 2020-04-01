using System.IO;

namespace I3DShapesTool.Lib.Model
{
  public class I3DUV
  {
    public float U { get; }
    public float V { get; }

    public I3DUV(BinaryReader br, int fileVersion)
    {
      if (fileVersion >= 4) // Can be 5 as well
      {
        //V = br.ReadSingle();
        //U = br.ReadSingle();

        // handling zero-length data
        try
        {
          V = br.ReadSingle();
        }
        catch (System.Exception)
        {
          V = 0;
        }
        try
        {
          U = br.ReadSingle();
        }
        catch (System.Exception)
        {
          U = 0;
        }
      }
      else
      {
        U = br.ReadSingle();
        V = br.ReadSingle();
      }
    }
  }
}
