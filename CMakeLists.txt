cmake_minimum_required(VERSION 2.8.12.2)
project(MultiPurposeProgram)

# Setting the files for the project
file(GLOB_RECURSE SOURCES "src/*.cpp")
file(GLOB_RECURSE HEADERS "src/*.h")

# Setting up the include Directories
set (INCLUDE_DIR "")
foreach(_headerFile ${HEADERS})
	get_filename_component(_dir ${_headerFile} PATH)
	list (APPEND INCLUDE_DIR ${_dir})
endforeach()

# Making sure there are only 1 of each include
list(REMOVE_DUPLICATES INCLUDE_DIR)

# Setting the include directories
include_directories(${INCLUDE_DIR})

set (RUNTIME_OUTPUT_DIRECTORY "../bin")
#exec
add_executable(muliPurpsoe ${SOURCES})
