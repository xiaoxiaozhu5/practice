import os
import sys

file_path = os.path.dirname(__file__) + '/list.txt'
file_exten = os.path.dirname(__file__) + "/extend.txt"

def list_item(path):
    cnt = 0
    output = open(path,'w')
    for root, dirs, files in os.walk('.'):
        for name in files:
            cnt += 1
            os.path.join(root,name)
            # print root + '\\' + name
            output.writelines(root + '\\' + name + '\n')
    output.close()
    print 'list file created at: %s' % file_path
    print 'Total files : %d ' % cnt

def get_extend(ext):
    cnt = 0
    output = open(file_exten,'w')
    for root, dirs, files in os.walk('.'):
        for name in files:
            if os.path.splitext(name)[1] == '.' + ext:
                cnt += 1
                os.path.join(root,name)
                # print root + '\\' + name
                output.writelines(root + '\\' + name + '\n')
    output.close()
    print 'extension file created at: %s' % file_exten
    print '*.%s files : %d ' % (ext, cnt)

def del_files(files):
    cnt = 0
    lines = [line.strip('\r\n') for line in open(files,'rb')]
    for i in lines:
        cnt =+ 1
        os.remove(i)
    print 'delete: %d files' % cnt

def get_lines(filepath):
    count = 0
    f_file = open(filepath,'rb')
    while True:
        buffers = f_file.read(8192*1024)
        if not buffers:
            break;
        count += buffers.count('\n')
    print count
    f_file.close()

def usage():
    print 'usage: reportlines.py [type] [d]'
    print '[type] : file extension name'
    print ' [d]   : delete files by extension name'

if __name__ == "__main__":
    if len(sys.argv) < 2:
        list_item(file_path)
    elif len(sys.argv) == 2:
        get_extend(sys.argv[1])
    else:
        if sys.argv[2] == 'd':
            del_files(file_exten)
        else:
            usage()
