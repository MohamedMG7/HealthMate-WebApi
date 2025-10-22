using HealthMate.DAL.Data.Models;
using HealthMate.DAL.Enums;
using HealthMate.DAL.Reposatiries;

namespace HealthMate.BLL.Healthtrend
{
	public class HealthTrend : IHealthTrend
	{
		private readonly IGenericRepository<Condition> _conditionRepo;
        private readonly IGenericRepository<Encounter> _encounterRepo;

        public HealthTrend(IGenericRepository<Condition> conditionRepo, IGenericRepository<Encounter> encounterRepo)
        {
            _conditionRepo = conditionRepo;
            _encounterRepo = encounterRepo;
        }
        //for the start the duration we are looking for to get the healthtrend is a monthe

        // all the diseases in the past month - search in conditions
        // all the medicaiton patient currently using // set to "No Medication ongoing for now"
        // all the critical activites in the past month - search in encounters
        // if there is some problem in the observations so it's critical to show - sugar in blood and blood presure as a start - for kids blood sugar should be less than

        // summaray diseases in the past month get the most critical
        public List<int> ConditionSummarayInThePastMonth(int patientId, int durationInMonth) // return a list of the ids of the conditions selected
		{
            // get all the conditions for the patient {id} in the past {durationInMonth} - order it so i get the most recent first
            var conditions = _conditionRepo.GetAll().Where(p => p.PaientId == patientId && p.DateRecorded >= DateTime.Now.AddMonths(-durationInMonth))
                .OrderByDescending(p => p.DateRecorded).Select(p => new { p.Condition_Id, p.Severity, p.DateRecorded }).ToList();

            // add 3 conditions at most - add all the severes even it will pass 3
            var selectedConditions = new List<int>();

            var severeConditions = conditions.Where(s => s.Severity == Severity.Severe).ToList();
            var otherConditions = conditions.Where(s => s.Severity != Severity.Severe).ToList();

            // add all severe conditions to the selected conditions
            selectedConditions.AddRange(severeConditions.Select(c => c.Condition_Id));

            // check if there is room to add more conditions add non-severe conditions
            if (selectedConditions.Count < 3) { 
                int remainingSlots = 3 - selectedConditions.Count;
                selectedConditions.AddRange(otherConditions.Take(remainingSlots).Select(c => c.Condition_Id));
            }
        
            return selectedConditions; 
		}

        // summary critical encounter in the past {durationInMonth}
        //public List<int> EncounterSummarayInThePastMonth(int patientId, int durationInMonth) {
        //    var encounters = _encounterRepo.GetAll().Where(p => p.PatientId == patientId && p.EndDate >= DateTime.Now.AddMonths(-durationInMonth)).OrderByDescending(e => e.EndDate).ToList();

        //    var selectedEncounters = new List<int>();
            
        //    // if the encounter is ICU it serves like severe for me - keyword thing

        //    //if encounter has severe condition get it 

        //}
	}
}
