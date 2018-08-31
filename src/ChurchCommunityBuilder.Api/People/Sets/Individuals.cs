using System;
using System.Collections.Generic;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.Util;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Individuals : BaseApiSet<IndividualCollection> {
        public Individuals(string baseUrl, string username, string password) : base(baseUrl, username, password) {}

        public IChurchCommunityBuilderResponse<IndividualCollection> Search(IndividualQO qo) {
            return this.Execute("individual_search", qo);
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> ExecuteSearch(int id)
        {
            var parameters = new Dictionary<string, string> {{"id", id.ToString()}};

            return this.Execute("execute_search", parameters);
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> List(IndividualQO qo)
        {
            return this.Execute("individual_profiles", qo);
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> List(DateTime lastModifiedDate, bool includeInactive)
        {
            var qo = new IndividualQO();
            qo.ModifiedSince = lastModifiedDate;
            qo.IncludeInactive = includeInactive;
            return this.Execute("individual_profiles", qo);
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> Get(int id, bool includeInactive) {
            var qo = new IndividualQO();
            qo.IndividualID = id;
            qo.IncludeInactive = includeInactive;
            var individuals = this.Execute("individual_profile_from_id", qo);
            return individuals;
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> Update(Individual entity) {
            if (entity.ID <= 0) {
                throw new Exception("An ID is required when updating an individual");
            }

            var parameters = new Dictionary<string, string>();
            parameters.Add("individual_id", entity.ID.ToString());
            return base.Update("update_individual", entity.GetFormValues(), parameters);
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> Create(Individual entity) {
            var individuals = base.Create("create_individual", entity.GetFormValues());
            return individuals;
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> Login(string username, string password) {
            int returnID = 0;

            var formValues = new FormValuesBuilder();
            if (!string.IsNullOrEmpty(username))
                formValues.Add("login", username);

            if (!string.IsNullOrEmpty(password))
                formValues.Add("password", password);

            var result = this.Execute("individual_id_from_login_password", formValues.ToString());
            return result;
        }

        public IChurchCommunityBuilderResponse<IndividualCollection> LoginProfile(string username, string password)
        {
            var formValues = new FormValuesBuilder();

            if (!string.IsNullOrEmpty(username))
                formValues.Add("login", username);
            
            if (!string.IsNullOrEmpty(password))
                formValues.Add("password", password);
            

            var individuals = this.Execute("individual_profile_from_login_password", formValues.ToString());
            return individuals;
        }
    }
}