
counter = 0
def get_number_number_of_fishes( fish : int, days : int ):
    if days < 0:
        return 0
    replication  = int((fish + days) / 6)
    while replication:
        global counter 
        
        get_number_number_of_fishes( 8, days - fish )  
        
        replication -= 1    
    counter +=1
    return 
get_number_number_of_fishes( 3 , 18 )
print(counter)