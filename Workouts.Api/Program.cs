var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/workouts", () =>
{
    var workouts = new Workout[]
    {
        new Workout
        {
            Id = 1,
            DayOfWeek = DayOfWeek.Tuesday,
            Exercise =
            [
                new Exercise
                {
                    Id = 1,
                    Name = "Lying Tricep Extension",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Triceps
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Incline Dumbbell Flies",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Chest
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Dumbbell Lateral Raises",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Shoulders
                }
            ],
        },
        new Workout
        {
            Id = 2,
            DayOfWeek = DayOfWeek.Thursday,
            Exercise =
            [
                new Exercise
                {
                    Id = 1,
                    Name = "Deadlift",
                    Description = "At least 2 sets of 12-16 reps.",
                    MuscleGroup = MuscleGroup.Back
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Bent Over Row",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Back
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Incline Crunches",
                    Description = "At least 2 sets. As many as possible.",
                    MuscleGroup = MuscleGroup.Abs
                },
                new Exercise
                {
                    Id = 4,
                    Name = "Dumbbell Curl",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Biceps
                }
            ],
        },
        new Workout
        {
            Id = 3,
            DayOfWeek = DayOfWeek.Friday,
            Exercise =
            [
                new Exercise
                {
                    Id = 1,
                    Name = "Push Ups",
                    Description = "At least 3 sets reps. As many as possible.",
                    MuscleGroup = MuscleGroup.Chest
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Standing Tricep Extension",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Triceps
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Military Press",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Shoulders
                }
            ],
        },
        new Workout
        {
            Id = 4,
            DayOfWeek = DayOfWeek.Sunday,
            Exercise =
            [
                new Exercise
                {
                    Id = 1,
                    Name = "Roman chair abs",
                    Description = "At least 2 sets. As many as possible.",
                    MuscleGroup = MuscleGroup.Abs
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Pull Ups",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Back
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Ez Bar Curls",
                    Description = "At least 3 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Biceps
                },
                new Exercise
                {
                    Id = 4,
                    Name = "Standing Dumbbell Shrugs",
                    Description = "At least 2 sets of 8-12 reps.",
                    MuscleGroup = MuscleGroup.Shoulders
                }
            ],
        }
    };

    return workouts;
})
.WithName("GetWorkouts")
.WithOpenApi();

app.Run();