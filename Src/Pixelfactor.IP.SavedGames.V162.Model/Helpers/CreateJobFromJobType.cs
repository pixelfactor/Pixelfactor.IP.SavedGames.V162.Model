using Pixelfactor.IP.SavedGames.V162.Model.Jobs;
using Pixelfactor.IP.SavedGames.V162.Model.Jobs.JobTypes;
using System;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public static class CreateJobFromJobType
    {
        public static Job CreateJob(JobType jobType)
        {
            switch (jobType)
            {
                case JobType.DestroyFleet:
                    return new DestroyFleetJob();
                case JobType.Courier:
                    return new CourierJob();
                case JobType.DeliverShip:
                    return new DeliverShipJob();
                case JobType.Breakdown:
                    return new BreakdownJob();
                default:
                    throw new NotImplementedException($"Unknown job type {(int)jobType}");
            }
        }
    }
}
