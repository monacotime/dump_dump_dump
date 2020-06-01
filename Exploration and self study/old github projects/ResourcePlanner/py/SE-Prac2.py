import operator as op
import csv
import itertools
#---------------------------
#all lists
t_num_tasks = 4
total_objects = []
bst_choices = []

#----------------------------
#Data extraction

class Employees:
    def __init__(self, eID, t1, t2, t3, t4):
        self.eID = eID
        self.t1 = t1
        self.t2 = t2
        self.t3 = t3
        self.t4 = t4

    def __repr__(self):
        return "({}: {}, {}, {}, {})".format(self.eID ,self.t1, self.t2, self.t3, self.t4)

with open("data_prac_2.csv") as csvfile:
    csv_data = csv.reader(csvfile, delimiter=",")

    for rows in csv_data:

        #making them into subset of a class
        rows[0]= Employees(rows[0], int(rows[1]), int(rows[2]), int(rows[3]), int(rows[4]))
        total_objects.append(rows[0])
#-----------------------------
#Data Management

for a in range(0,t_num_tasks):
    task_range = "t"+ str(a+1)
    lwst_value = sorted(total_objects, key=op.attrgetter(task_range))
    bst_choices.append(lwst_value[0])
#-----------------------------
#output
for i in range(0,len(bst_choices)):
    print("For task", i+ 1, ": ", bst_choices[i])

input("enter")
