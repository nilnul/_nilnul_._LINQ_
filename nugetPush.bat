set p=3
set pack=_nilnul_._LINQ_.1.0.%p%.nupkg

nuget push -source local %pack%
nuget push -source my %pack%
@pause
