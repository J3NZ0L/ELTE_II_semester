#include <stdio.h>
#include <stdlib.h>
#include <time.h>

const char* orc_names[] = {"Grommash", "Kargath", "Durotan", "Zuluhed", "Kilrogg", "Ner'zhul", "Gul'dan", "Blackhand", "Doomhammer", "Hellscream"};
const char* elf_names[] = {"Legolas", "Thranduil", "Galadriel", "Elrond", "Arwen", "Celeborn", "Glorfindel", "Erestor", "Cirdan", "Gildor"};
const char* orc_subtypes[] = {"fe", "cu", "ca"};
const char* elf_subtypes[] = {"re", "wi", "de"};

int main() {
    srand(time(NULL));
    time_t t = time(NULL);
    struct tm tm = *localtime(&t);
    char filename[20];
    sprintf(filename, "test%02d%02d%02d.txt", tm.tm_hour, tm.tm_min, tm.tm_sec);

    FILE *file = fopen(filename, "w");
    if (file == NULL) {
        printf("Error opening file!\n");
        return 1;
    }

    for (int i = 0; i < rand()%20; i++) {
        int creature_type = rand() % 2;
        if (creature_type == 0) { // Orc
            fprintf(file, "%s o %s %d ", orc_names[rand() % 10], orc_subtypes[rand() % 3], rand() % 31);
        } else { // Elf
            fprintf(file, "%s e %s ", elf_names[rand() % 10], elf_subtypes[rand() % 3]);
        }
    }

    fclose(file);
    return 0;
}

