<<<<<<< HEAD
﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
=======
﻿//---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
//----------------------------------------------------------------

using System.Linq;
>>>>>>> ef731125589f73b5a7c937a68dc7df752e17ae8c
using System.Threading.Tasks;
using OtripleS.Web.Api.Brokers.DateTimes;
using OtripleS.Web.Api.Brokers.Loggings;
using OtripleS.Web.Api.Brokers.Storage;
using OtripleS.Web.Api.Models.StudentExamFees;
<<<<<<< HEAD
=======
using OtripleS.Web.Api.Services.StudentStudentExamFees;
>>>>>>> ef731125589f73b5a7c937a68dc7df752e17ae8c

namespace OtripleS.Web.Api.Services.StudentExamFees
{
    public partial class StudentExamFeeService : IStudentExamFeeService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;
        private readonly IDateTimeBroker dateTimeBroker;

        public StudentExamFeeService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker,
            IDateTimeBroker dateTimeBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
            this.dateTimeBroker = dateTimeBroker;
        }

<<<<<<< HEAD
        public ValueTask<StudentExamFee> RemoveStudentExamFeeByIdAsync(
            Guid studentExamFeeId) =>
            TryCatch(async () =>
            {
                ValidateStudentExamFeeId(studentExamFeeId);

                StudentExamFee maybeStudentExamFee =
                    await this.storageBroker.SelectStudentExamFeeByIdAsync(studentExamFeeId);

                ValidateStorageStudentExamFee(maybeStudentExamFee, studentExamFeeId);

                return await this.storageBroker.DeleteStudentExamFeeAsync(maybeStudentExamFee);
            });
=======
        public ValueTask<StudentExamFee> AddStudentExamFeeAsync(StudentExamFee studentExamFee) =>
        TryCatch(async () =>
        {
            ValidateStudentExamFeeOnCreate(studentExamFee);

            return await this.storageBroker.InsertStudentExamFeeAsync(studentExamFee);
        });

        public IQueryable<StudentExamFee> RetrieveAllStudentExamFees() =>
        TryCatch(() =>
        {
            IQueryable<StudentExamFee> storageStudentExamFees = this.storageBroker.SelectAllStudentExamFees();

            ValidateStorageStudentExamFees(storageStudentExamFees);

            return storageStudentExamFees;
        });

>>>>>>> ef731125589f73b5a7c937a68dc7df752e17ae8c
    }
}
