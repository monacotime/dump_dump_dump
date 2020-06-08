
class A2:
    def info(self,no,y):
        self.roll_no = no
        self.no_sub = y

jack = A2.info(jack,15,6)

print(jack)

# #--------------------------------------
# import itertools
#
# y = [1,2,3]
#
# x = list(itertools.combinations(y,2))
#
# print (x)
# #---------------------------------------------
# import operator as op
# import csv
# import itertools
#
# class Employees:
#     def __init__(self, name, hrs):
#         self.name = name
#         self.hrs = hrs
#
#     def __repr__(self):
#         return "({},{})".format(self.name, self.hrs)
#
# #total instance of a class
# total_objects = []
# srt_total_objects = []
#
#
# with open("data_prac_1.csv") as csvfile:
#     csv_data = csv.reader(csvfile, delimiter=",")
#
#     for rows in csv_data:
#         #making them into subset of a class
#         rows[0]= Employees(rows[1], float(rows[2]))
#
#         total_objects.append(rows[0])
#
#
# srt_total_objects= sorted(total_objects, key=op.attrgetter("hrs"))
#
#
# print(total_objects)
# print(srt_total_objects)

# def srt(org_lst, new_lst, srt_with):
#      new_lst= sorted(org_lst, key=op.attrgetter(srt_with))
#
#
#
# srt(total_objects, srt_total_objects, "hrs")
#
# with open("emp_data.csv") as csvfile:
#     csv_data = csv.reader(csvfile, delimiter=",")
#
#     emp_names = []
#     emp_hrs = []
#
#     for row in csv_data: #organising
#         #row is a array (x,x)!
#         ext_name = row[0] #ext = extraction
#         ext_hrs = row[1] #ext = extraction
#
#         emp_names.append(ext_name)
#         emp_hrs.append(ext_hrs)
#
# print(emp_names)
# print(emp_hrs)
#
#
# combination = itetools.combination(the_list_that_you_want, how many per set eg: 2)
#
#
# class Employees:
#     def __init__(self, name, hrs):
#         self.name = name
#         self.hrs = hrs
#
#     def __repr__(self):
#         return "({},{})".format(self.name, self.hrs)
#
# def srt():
#     emp_lst_s = sorted(emp_lst, key=op.attrgetter("e_name"))
#     print(emp_lst_s)
#
# srt()
