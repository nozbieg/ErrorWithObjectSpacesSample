;#DropDB ErrorWithObjectSpacesSampleEasyTest

#Application ErrorWithObjectSpacesSampleWin
#Application ErrorWithObjectSpacesSampleWeb
#IfDef ErrorWithObjectSpacesSampleWin

*Action About...
 
*Action OK

#EndIf

#IfDef ErrorWithObjectSpacesSampleWeb
!Action Navigation(My Details)
#EndIf
