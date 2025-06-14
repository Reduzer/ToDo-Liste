type Project = {
    nProjectID : number;
    sProjectName : string;
    sProjectDescription : string;
    nCreaterID : number;
    oCreationDate : Date;
    oStartDate : Date;
    oPlanedEnddate : Date;
    oActualEnddate : Date;
    anUsers : number[];
    anTasks : number[];
}