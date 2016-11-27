using AutoMapper;
using Models.Models;
using Models.Models.Lookup;

namespace Repository.Config
{
    public class RepositoryMapperConfig : Profile
    {
        public RepositoryMapperConfig()
        {
            #region Lookup models

            CreateMap<DAL.Models.Lookup.Country, Country>();
            CreateMap<DAL.Models.Lookup.Category, Category>();
            CreateMap<DAL.Models.Lookup.Modifier, Modifier>();
            CreateMap<DAL.Models.Lookup.QuestionType, QuestionType>();

            #endregion Lookup models

            #region Area models

            CreateMap<DAL.Models.Image, Image>();
            CreateMap<Image, DAL.Models.Image>();

            CreateMap<DAL.Models.Answer, Answer>();
            CreateMap<Answer, DAL.Models.Answer>();

            CreateMap<DAL.Models.Question, Question>();
            CreateMap<Question, DAL.Models.Question>();

            CreateMap<DAL.Models.Quiz, Quiz>();
            CreateMap<Quiz, DAL.Models.Quiz>();

            CreateMap<DAL.Models.QuizRound, QuizRound>();
            CreateMap<QuizRound, DAL.Models.QuizRound>();

            CreateMap<DAL.Models.QuizTeam, QuizTeam>();
            CreateMap<QuizTeam, DAL.Models.QuizTeam>();

            CreateMap<DAL.Models.RoundQuestion, RoundQuestion>();
            CreateMap<RoundQuestion, DAL.Models.RoundQuestion>();

            CreateMap<DAL.Models.Team, Team>();
            CreateMap<Team, DAL.Models.Team>();

            CreateMap<DAL.Models.TeamAnswer, TeamAnswer>();
            CreateMap<TeamAnswer, DAL.Models.TeamAnswer>();

            CreateMap<DAL.Models.TeamMember, TeamMember>();
            CreateMap<TeamMember, DAL.Models.TeamMember>();

            #endregion Area models
        }
    }
}