using CensusAnalyzer_Day29;
using CensusAnalyzer_Day29.CustomException;
using NUnit.Framework;

namespace CensusAnalyzerTest
{
    public class Tests
    {
        LoadCensusData loadCensusData;
        private readonly string INDIAN_CENSUS_FILE_PATH = @"C:\Users\hp\source\CensusAnalyzerTest\Resourses\IndiaStateCensusData.csv - IndiaStateCensusData.csv.csv";
        private readonly string INDIAN_CENSUS_FILE_PATH_WrongHeader = @"C:\Users\hp\source\CensusAnalyzerTest\Resourses\IndiaStateCensusData - Copy.csv - IndiaStateCensusDataWithWrongHeader.csv.csv";
        private readonly string INDIAN_CENSUS_FILE_PATH_WrongFileType = @"C:\Users\hp\source\CensusAnalyzerTest\Resourses\IndiaStateCensusData - Copy.txt - IndiaStateCensusData.csv.txt";

        [SetUp]
        public void Setup()
        {
            loadCensusData = new LoadCensusData();

        }
        [Test]
        public void LoadIndianStateCensusData()
        {
           int count = loadCensusData.LoadCensusDataIntoList(INDIAN_CENSUS_FILE_PATH);
            Assert.AreEqual(29, count);
        }
        //TC-1.1 = Count was not matches
        [Test]
        public void LoadIndianStateCensusData_whenCountNotMatches()
        {
            int count = loadCensusData.LoadCensusDataIntoList(INDIAN_CENSUS_FILE_PATH);
            Assert.AreEqual(30, count);
        }
        //TC-1.2 = Wrong Header FilePath
        [Test]
        public void LoadIndianStateCensusDataWithWrongHeader_ExpectingAppropriateErrorMessage()
        {
            try
            {
                var result = loadCensusData.LoadCensusDataIntoList(INDIAN_CENSUS_FILE_PATH_WrongHeader);
            }
            catch(CecsusAnalyzerException CE)
            {
                Assert.AreEqual("WrongHeader",CE.Message);
            }
        }
        //TC-1.3 = Wrong FileType
        [Test]
        public void LoadIndianStateCensusDataWithWrongFileType_ExpectingAppropriateErrorMessage()
        {
            try
            {
                var result = loadCensusData.LoadCensusDataIntoList(INDIAN_CENSUS_FILE_PATH_WrongHeader);
            }
            catch (CecsusAnalyzerException CE)
            {
                Assert.AreEqual("WrongHeader", CE.Message);
            }
        }

    }
}