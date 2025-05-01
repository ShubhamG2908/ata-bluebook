using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace ATA.Infrastructure.Common;

public class SequentialGuidValueGenerator : ValueGenerator<Guid>
{
    public override bool GeneratesTemporaryValues => false;

    public override Guid Next(EntityEntry entry)
    {
        return SequentialGuid();
    }

    private static Guid SequentialGuid()
    {
        var guidArray = Guid.NewGuid().ToByteArray();
        var timestamp = BitConverter.GetBytes(DateTime.UtcNow.Ticks);

        // Swap bytes to create sequential ordering
        Array.Copy(timestamp, 0, guidArray, guidArray.Length - timestamp.Length, timestamp.Length);

        return new Guid(guidArray);
    }
}
